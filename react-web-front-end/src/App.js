import React, { Component } from 'react';
import './App.css';

class App extends Component {

  constructor(props) {
    super(props);
    console.log("App-komponentti: konstruktori (rakentaja).");

    this.state = { tuotteet: [] };
  }

  componentDidMount() {

    // console.log("App-komponentti: componentDidMount-metodissa.");
    // this.setState({ title: "Väliaikainen otsikko"} );

    fetch('http://localhost:62927/api/tietokanta')
      .then(response => response.json())
      .then(json => {
        console.log(json);

        console.log("App-komponentti: aloitetaan setState()-kutsu.");
        this.setState({ tuotteet: json });
        console.log("App-komponentti: setState()-metodia kutsuttu.");

      });

    console.log("App-komponentti: Fetch-kutsu tehty.");
  }

  render() {

    console.log("App-komponentti: render-metodissa.");

    let viesti = "";
    let taulukko = [];
    if (this.state.tuotteet.length > 0) {

      for (let index = 0; index < this.state.tuotteet.length; index++) {
        const element = this.state.tuotteet[index];
        taulukko.push(<tbody><tr>
          <td>{element.tuotenimi}</td>
          <td>{element.malli}</td>
          <td>{element.vastuutaho}</td>
        </tr></tbody>);

      }
      
    }
    else {
      viesti = "Ladataan tietoja..."
    }

    return (<div>
      <h1>Vaaralliset tuotteet</h1>
      <p>{viesti}</p>
      <table>
      {taulukko}
      </table>
    </div>
    );
  }
}

export default App;
