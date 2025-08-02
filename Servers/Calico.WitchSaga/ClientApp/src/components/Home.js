import React, { Component } from 'react';
import {KillCalculator} from "./KillCalculator";

export class Home extends Component {
  static displayName = Home.name;

  render() {
    return (
      <div className="justify-content-center vh-100 align-items-center d-flex flex-column">
            <img className="w-50" src="witch.png"/>
            <KillCalculator/>
      </div>
    );
  }
}
