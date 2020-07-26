import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
        <h1>Welcome to Trips Manager!</h1>
        <p>Use this manager to manage your trips by:</p>
        <ul>
          <li>Adding a new trip</li>
          <li>Updating a trip</li>
          <li>Deleting a trip</li>
          <li>Viewing all the trips</li>
        </ul>
      </div>
    );
  }
}
