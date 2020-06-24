import React, { Component } from 'react';
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import './NavMenu.css';


export class NavMenu extends Component {
  static displayName = NavMenu.name;

  constructor (props) {
    super(props);

    this.toggleNavbar = this.toggleNavbar.bind(this);
    this.state = {
      collapsed: true
    };
  }

  toggleNavbar () {
    this.setState({
      collapsed: !this.state.collapsed
    });
  }

  render () {
    return (
        <nav class="navbar navbar-expand-lg ">
            <div class="collapse navbar-collapse " id="navbarSupportedContent">
                <ul class="navbar-nav mr-4">
                    <li class="nav-item">
                        <a class="nav-left-1" href="#">Rus/Eng</a>
                    </li>
                    <li class="nav-item">
                        |
                        </li>
                    <li class="nav-item">
                        <a class="nav-left-1" href="#">Помощь</a>
                    </li>
                </ul>
                <ul className="navbar-nav d-flex flex-sm-row-reverse">
                    <li class="nav-item " >
                        <NavbarBrand tag={Link} to="/registration">
                            <a href="#">Регистрация</a>
                        </NavbarBrand>
           
                    </li>
                    <li class="nav-item">
                        |
                        </li>
                    <li class="nav-item">
                        <NavbarBrand tag={Link} to="/entry">
                            <a href="#" >Вход</a>
                        </NavbarBrand>
                        </li>                   
                </ul>
            </div>
        </nav>
    );
  }
}
