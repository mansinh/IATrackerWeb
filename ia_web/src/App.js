import React, { useState, Component } from 'react';
import { BrowserRouter, Switch, Route } from 'react-router-dom';
import { TransitionGroup, CSSTransition } from 'react-transition-group';
import MainMenu from './screens/MainMenu';
import CharacterSelectScreen from './screens/CharacterSelectScreen';
import CharacterScreen from './screens/CharacterScreen';

import './App.css';

let currentCharacter

const App = () => {


    return (
        <BrowserRouter>

            <Switch>
                <Route exact path="/" component={MainMenu} />
                <Route exact path="/characterSelect" component={CharacterSelectScreen} />
                <Route exact path="/character" component={CharacterScreen} />
            </Switch>


            <div className="border"></div>
        </BrowserRouter>

    );
}

export default App;