import React, { Component } from 'react';
import './App.css';

var data = [{name:'Jhon', age:28, city:'HO'},
            {name:'Onhj', age:82, city:'HN'},
            {name:'Nohj', age:41, city:'IT'}
           ];

var Hello = React.createClass({

    render: function() {

      var _data = this.props.info;
      console.log(_data);
      return(
        <div>
            {_data.map(function(object, i){
               return <div className={"row"} key={i}> 
                          {[ object.name ,
                             // remove the key
                             <b className="fosfo" key={i}> {object.city} </b> , 
                             object.age
                          ]}
                      </div>; 
             })}
        </div>
       );
    }
});

React.render(<Hello info={data} />, document.body);

