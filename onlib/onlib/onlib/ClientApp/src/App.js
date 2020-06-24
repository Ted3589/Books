import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import { Registration } from './components/pages/Registration';
import { CatalogBooks } from './components/pages/CatalogBooks';
import { Entry } from './components/pages/entry';
import { Basket } from './components/pages/Basket';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
            <Route path='/fetch-data' component={FetchData} />
            <Route path='/registration' component={Registration} />
            <Route path='/entry' component={Entry} />
            <Route path='/CatalogBooks' component={CatalogBooks} />
            <Route path='/basket' component={Basket} />
      </Layout>
    );
  }
}
