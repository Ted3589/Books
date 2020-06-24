import React, { Component } from 'react';
import { Button } from 'reactstrap';
import { Pagination, PaginationItem, NavLink, PaginationLink } from 'reactstrap';
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem } from 'reactstrap';
import { Link } from 'react-router-dom';
import './Basket.css'

const fakeBooks = [
    {
        name: 'Nordway Combi',
        price: 1199
    }
];

export class Basket extends Component {

    constructor(props) {
        super(props);
        this.state = {
            books: fakeBooks   
        };
    }
    componentDidMount() {
        this.getCarts();
    }

    renderBooks = () => {
        const {
            books
        } = this.state;

       
        return books.map((books) => {
           
                return (
                    <div className="table">
                        <p className="">{books.id}</p>
                    </div>
                )
            
        })
    }

    renderBooks1 = () => {
        const {
            books
        } = this.state;


        return books.map((books) => {

            return (
                <div className="table">
                    <p className="">{books.name}</p>
                </div>
            )

        })
    }

    renderBooks2 = () => {
        const {
            books
        } = this.state;


        return books.map((books) => {

            return (
                <div className="table">
                    <p className="">{books.price} ₽</p>
                </div>
            )

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
                <table class="table">
                    <thead>
                        <tr>
                            <th>Товар</th>
                            <th>Название</th>
                            <th>Цена</th>
                        </tr>
                    </thead>                 
                    <tbody>
                        <tr>
                            <td>{this.renderBooks()} </td>
                            <td>{this.renderBooks1()} </td>
                            <td>{this.renderBooks2()} </td>
                        </tr>                      
                    </tbody>
                </table>
                <div className="input-group-append d-flex flex-row-reverse battons">
                    <button className="btn btn-outlane-info my-2 my-sm-0 mr-5" type="submit" id="buttons" >Оформить заказ</button>
                </div>       
            </div>
        );
    }  
}