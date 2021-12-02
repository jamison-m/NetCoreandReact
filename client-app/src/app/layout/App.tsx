import React, { Fragment, useEffect, useState } from 'react';
import axios from 'axios';
import { Container, Header, List } from 'semantic-ui-react';
import { Activity } from '../models/activity';
import NavBar from './NavBar';
import ActivityDashboard from '../../features/activities/dashboard/ActivityDashboard';

function App() {
  const[activities, setActivities] = useState<Activity[]>([]);

  useEffect(() => {
    //Now very typesafe
    axios.get<Activity[]>('http://localhost:5000/api/activities').then(response => {
      console.log(response);
      setActivities(response.data);
    })
  }, /*need to add array of dependencies to make sure that use effect only runs one time*/ []) 

  return (
    //need div or fragment encompassing code because otherwise we are not allowed to return two different elements at the same level inside a react component. could also do a empty tag for shorthand of fragment
    <Fragment>
      <NavBar/>
      <Container style={{marginTop: '7em'}}>
          <ActivityDashboard activities={activities}/>
      </Container>
        
    </Fragment>
  );
}

export default App;
