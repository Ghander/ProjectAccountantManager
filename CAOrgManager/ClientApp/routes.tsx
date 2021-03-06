import * as React from 'react';
import { Route } from 'react-router-dom';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import { FetchOrgCA } from './components/FetchOrgCA';

export const routes = <Layout>
    <Route exact path='/' component={FetchOrgCA} />
    <Route path='/fetchorgcas' component={FetchOrgCA} />  
    {/*<Route path='/counter' component={ Counter } />
    <Route exact path='/' component={Home} />
    <Route path='/fetchdata' component={ FetchData } />*/}
</Layout>;
