import 'reflect-metadata';
import { StatusBar } from 'expo-status-bar';
import React from 'react';
import configureStore from './src/store/Store'
import { Provider } from 'react-redux';
import { BrowserHistoryOptions, createBrowserHistory } from 'history';
import Layout from './src/components/core/Layout';
import { NativeRouter, Route } from 'react-router-native';
import Home from './src/components/home/Home';
import FetchData from './src/components/fetchdata/FetchData';
import { UIProvider } from 'react-native-web-ui-components';
import theme from './Theme'
import Counter from './src/components/counter/Counter';

//const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href') as string;
const options: BrowserHistoryOptions = {};
 
const history = createBrowserHistory(options);
const store = configureStore(history);

export default function App() {
  return (
    <Provider store={store}>
      <NativeRouter>

        <UIProvider theme={theme} history={history}>
          <Layout>
            <Route exact={true} path='/' component={Home} />
            <Route path='/counter' component={Counter} />
            <Route path='/fetch-data/:startDateIndex?' component={FetchData} />
          </Layout>
          <StatusBar style="auto" />
        </UIProvider>

      </NativeRouter>
    </Provider>
  );
}
