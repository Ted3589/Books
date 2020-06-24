import React, { Component } from 'react';
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import './pages/style.css';
import logo from '../images/logo.PNG';
import profile from '../images/profile.jpg'
import basket from '../images/basket.png'
import img0 from '../images/Снимок.PNG'
import img1 from '../images/Снимок1.PNG'
import img2 from '../images/Снимок2.PNG'
import img3 from '../images/Снимок3.PNG'
import img4 from '../images/Снимок4.PNG'
import { Link } from 'react-router-dom';



export class Home extends Component {
    static displayName = Home.name;

  render () {
    return (
        <div>
            <nav className="navbar navbar-expand-lg ">  
                <img className="news-photo mr-4" src={logo} alt="img" />         
                <form className="form1">                 
                    <div className="input-group">
                        <input className="form-control mr-sm-2" type="text" placeholder="Search" />
                        <div className="input-group-append">
                            <button className="btn btn-outlane-info my-2 my-sm-0 mr-5" type="submit" id="buttons">Поиск</button>                           
                        </div>
                        <div className="d-flex flex-row">
                            <button type="button" class="btn btn-default  btn-lg mr-3"><img className="img1" src={profile} alt="img" /></button>
                           
                                <button type="button" class="btn btn-default  btn-lg">
                                    <NavbarBrand tag={Link} to="/basket">
                                    <img className="img1" src={basket} alt="img" />
                                </NavbarBrand>
                            </button>
                            
                        </div>
                    </div>
                </form>
            </nav>          
            <nav class="navbar navbar-expand-lg bg-primary">
                <div class="collapse navbar-collapse " id="navbarSupportedContent">
                <ul class="navbar-nav lala mr-4">
                        <li class="nav-item">
                            <NavbarBrand tag={Link} to="/CatalogBooks">
                                <a class="nav-left mr-4" href="#">Книги</a>
                            </NavbarBrand>
                    </li>                
                    <li class="nav-item">
                        <a class="nav-left mr-4" href="#">Я-Автор</a>
                    </li> 
                    <li class="nav-item">
                        <a class="nav-left mr-4" href="#">Новости</a>
                    </li>  
                    </ul>
                </div>
            </nav>
            <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
                <div class="collapse navbar-collapse " id="navbarSupportedContent">
                    <ul class="navbar-nav lala mr-4">
                        <li class="nav-item">
                            <a class="nav-left mr-4" href="#">Бестсейллеры</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-left mr-4" href="#">Новинки</a>
                        </li>                     
                    </ul>
                </div>
            </nav>
            <div class="card centerb mr-4">
                <img className="photob" src={img0} alt="img" />
                <div class="card-body"> Joanne Rowling</div>
                <NavbarBrand tag={Link} to="/basket">
                    <button className="btn btn-outlane-info centerbtn my-2 my-sm-0 mr-5" type="submit" id="buttons">В корзину</button>
                </NavbarBrand>
            </div>   
            <div class="card mr-4">
                <img className="photob" src={img1} alt="img" />
                <div class="card-body"> Joanne Rowling </div>
                <NavbarBrand tag={Link} to="/basket">
                    <button className="btn btn-outlane-info centerbtn my-2 my-sm-0 mr-5" type="submit" id="buttons">В корзину</button>
                </NavbarBrand>
            </div>  
            <div class="card mr-4">
                <img className="photob" src={img2} alt="img" />
                <div class="card-body"> Joanne Rowling </div>
                <NavbarBrand tag={Link} to="/basket">
                    <button className="btn btn-outlane-info centerbtn my-2 my-sm-0 mr-5" type="submit" id="buttons">В корзину</button>
                </NavbarBrand>
            </div> 
            <div class="card mr-4">
                <img className="photob" src={img3} alt="img" />
                <div class="card-body"> Joanne Rowling  </div>
                <NavbarBrand tag={Link} to="/basket">
                    <button className="btn btn-outlane-info centerbtn my-2 my-sm-0 mr-5" type="submit" id="buttons">В корзину</button>
                </NavbarBrand>
            </div> 
            <div class="card">
                <img className="photob" src={img4} alt="img" />
                <div class="card-body">
                    Joanne Rowling
                </div>
                <NavbarBrand tag={Link} to="/basket">
                    <button className="btn btn-outlane-info centerbtn my-2 my-sm-0 mr-5" type="submit" id="buttons">В корзину</button>
                </NavbarBrand>
            </div>          
        </div>
      );
  }
}
