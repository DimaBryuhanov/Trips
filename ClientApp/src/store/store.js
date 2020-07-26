import {createStore, applyMiddleware} from 'redux';
import thunk from 'redux-thunk';
import rooReducer from '../reducers/index';

const configureStore = () => applyMiddleware(thunk)(createStore)(rooReducer);

export default configureStore;
