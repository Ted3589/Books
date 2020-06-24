import React, { Component } from 'react';
import { Pagination, PaginationItem, NavLink, PaginationLink } from 'reactstrap';
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem } from 'reactstrap';
import './CatalogBooks.css';
import { Link } from 'react-router-dom';
import { Button } from 'reactstrap';

const fakeBooks = [
    {
        name: 'Nordway Combi',
        price: 1199
    }
];

export class CatalogBooks extends Component {
    static displayName = 'Весь каталог книг';

    constructor(props) {
        super(props);
        this.state = {
            books: fakeBooks,
            countView: 4,
            countPagination: 1,
        };
    }

   
    componentDidMount() {
        this.getCarts();
    }

    onClickPagination = (str) => {
        const {
            books,
            countView
        } = this.state;

        const maxStep = Math.ceil(books.length / countView);
        if (str !== 0 && str <= maxStep) {
            this.setState({ countPagination: str })
        }
    }

    testPagination = (props) => {
        return (
            <Pagination size="sm" aria-label="Page navigation example">
                <PaginationItem>
                    <PaginationLink previous onClick={() => this.onClickPagination(this.state.countPagination - 1)} />
                </PaginationItem>
                <PaginationItem>
                    <PaginationLink onClick={() => this.onClickPagination(1)}>
                        1
          </PaginationLink>
                </PaginationItem>
                <PaginationItem>
                    <PaginationLink onClick={() => this.onClickPagination(2)}>
                        2
          </PaginationLink>
                </PaginationItem>
                <PaginationItem>
                    <PaginationLink onClick={() => this.onClickPagination(3)}>
                        3
          </PaginationLink>
                </PaginationItem>
                <PaginationItem>
                    <PaginationLink onClick={() => this.onClickPagination(4)}>
                        4
          </PaginationLink>
                </PaginationItem>
                <PaginationItem>
                    <PaginationLink onClick={() => this.onClickPagination(5)}>
                        5
          </PaginationLink>
                </PaginationItem>
                <PaginationItem>
                    <PaginationLink next onClick={() => this.onClickPagination(this.state.countPagination + 1)} />
                </PaginationItem>
            </Pagination>
        );
    };



    renderBooks = () => {
        const {
            books,
            countView,
            countPagination,            
        } = this.state;

        const minValue = countView * (countPagination - 1);//с какой карточки начинается стр
        const maxValue = countView * countPagination;

        return books.map((books, i) => {        
            if (minValue <= i && i < maxValue) {
                return (
                    <div className="portfolio  col-md-3">
                        <NavbarBrand tag={Link} to="/basket">
                            <img src={`${books.pictures}`} alt="" />
                        </NavbarBrand>
                        <p className="">{books.name}</p>
                        <p className="">{books.price} ₽</p>
                        
                    </div>
                )
            }
        })
    }

    async getCarts() {
        const response = await fetch('Catalogs');
        const data = await response.json();
        this.setState({ books: data });
    }

    render() {
        return (
            <div>
                <div class="portfolio">
     <h1 class="text-center">Книги</h1>
 <div class="container">
  <div class="row">
                                {this.renderBooks()}  
  </div>
 </div>
</div>
                
                {this.testPagination()}
            </div>
        );
    }
}