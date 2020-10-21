import React from 'react';
import logo from './logo.svg';
import './App.css';
import axios from 'axios';

class App extends React.Component {
  state = {
    values: []
  }
  
  componentDidMount() {
    axios.get('http://localhost:5000/api/values')
      .then((response) => {
        this.setState({
          values: response.data
        })
      })
  }


  render() {
    return (
      <div className="App">
        <header className="App-header">
          BlogBox
        </header>
        {this.state.values.map((value: any) => <div key={value}>{value}</div>)}
      </div>
    );
  }
}

export default App;
