import React, { Component } from 'react';
import './Footer.css';

export class Footer extends Component {
    render() {
        return (
            <footer>
                <p className="text-white text-center">«Books» - <b>книжный интернет-магазин</b></p>
                <p className="text-white text-center"><b>Контактный телефон:</b> +8800553535</p>
                <p className="text-white text-center">books@mail.ru</p>
            </footer>
        );
    }
}