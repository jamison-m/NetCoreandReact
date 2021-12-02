//react it is convention to use TITLE CASE
import React from "react";
//Semantic UI has a 16 column grid
import { Grid, List } from "semantic-ui-react";
import { Activity } from '../../../app/models/activity';
import ActivityList from "./ActivityList";

//How to specify types within components
interface Props{
    activities: Activity[];
}

//could do props: Props
//Could also do {activities}: Props, destructures the properties we are passing down from the activities dashboard, removes need for props.activities
export default function ActivityDashboard({activities}: Props) {
    return (
        <Grid>
            <Grid.Column width='10'>
            <ActivityList activities={activities}/>
            </Grid.Column>
        </Grid>
    )
}