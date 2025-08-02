import React, { Component } from 'react';

export class KillCalculator extends Component {
    static displayName = KillCalculator.name;

    constructor(props) {
        super(props);
        this.state = { 
            averageKills: 0, 
            ageOfDeathA: 0,
            ageOfDeathB: 0,
            loading: false,
            yearOfDeathA: 0,
            yearOfDeathB: 0};
        this.calculateAverageKills = this.calculateAverageKills.bind(this);
    }
    
    render() {
        return (
            <div className="w-75 d-flex flex-column align-items-center">
                <h1>Kill Calculator</h1>
                <div className="container-fluid mt-4 d-flex flex-column align-items-center">
                    <div className="row w-50 g-2 mb-3">
                        <div className="col-6">
                            <label className="form-label">Person A's age of death</label>
                            <input 
                                type="number" 
                                className="form-control" 
                                defaultValue={this.state.ageOfDeathA} 
                                onChange={this.updateAgeOfDeathA} 
                                onKeyDown={this.validateKeyPress}/>
                        </div>
                        <div className="col-6">
                            <label className="form-label">Person A's year of death</label>
                            <input 
                                type="number" 
                                className="form-control" 
                                defaultValue={this.state.yearOfDeathA} 
                                onChange={this.updateYearOfDeathA}
                                onKeyDown={this.validateKeyPress}/>
                        </div>
                    </div>
                    <div className="row w-50 g-2 mb-3">
                        <div className="col-6">
                            <label className="form-label">Person B's age of death</label>
                            <input 
                                type="number" 
                                className="form-control" 
                                defaultValue={this.state.ageOfDeathB} 
                                onChange={this.updateAgeOfDeathB}
                                onKeyDown={this.validateKeyPress}/>
                        </div>
                        <div className="col-6">
                            <label className="form-label">Person B's year of death</label>
                            <input 
                                type="number" 
                                className="form-control" 
                                defaultValue={this.state.yearOfDeathB} 
                                onChange={this.updateYearOfDeathB}
                                onKeyDown={this.validateKeyPress}/>
                        </div>
                    </div>
                    <button className="btn btn-warning" onClick={this.calculateAverageKills}>
                        Calculate
                    </button>
                </div>
                <h1 className="m-3">Average kills: {this.state.averageKills}</h1>
            </div>
        );
    }

    async calculateAverageKills() {
        const aodA = this.state.ageOfDeathA.valueOf();
        const aodB = this.state.ageOfDeathB.valueOf();
        const yodA = this.state.yearOfDeathA.valueOf();
        const yodB = this.state.yearOfDeathB.valueOf();
        
        const deathInfos = [
            {ageOfDeath: aodA, yearOfDeath: yodA},
            {ageOfDeath: aodB, yearOfDeath: yodB}];
        const body = JSON.stringify(deathInfos);
        console.log(body);
        const response = await fetch('api/killcalculator/calculate',
            {
                method: 'POST',
                body: body,
                headers: {
                    "Content-Type": "application/json",
                }
            });
        const data = await response.json();
        this.setState({ averageKills: data, loading: false });
    }
    
    validateKeyPress = (e) => {
        if (!/[0-9]|Backspace|Tab|Enter|Delete|ArrowLeft|ArrowRight/.test(e.key)) {
            e.preventDefault();
        }
    }

    updateAgeOfDeathA = (ageOfDeathA) => {
        this.setState({ageOfDeathA: ageOfDeathA.target.value});
    }

    updateAgeOfDeathB = (ageOfDeathB) => {
        this.setState({ageOfDeathB: ageOfDeathB.target.value});
    }

    updateYearOfDeathA = (yearOfDeathA) => {
        this.setState({yearOfDeathA: yearOfDeathA.target.value});
    }

    updateYearOfDeathB = (yearOfDeathB) => {
        this.setState({yearOfDeathB: yearOfDeathB.target.value});
    }
}