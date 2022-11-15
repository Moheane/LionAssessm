import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';
import "bootstrap/dist/css/bootstrap.min.css";
import Select from 'react-select';
import axios from "axios";
import React, { Fragment, useEffect, useState } from 'react';
import TextField from '@material-ui/core/TextField';



export default function Request() {
  const [data, setData] = useState([]);
  const [firstName, setFirstName] = useState('');
  const [lastName, setlastName] = useState('');
  const [typeofLeave, settypeofLeave] = useState('');
  const [reason, setreason] = useState('');
  const [leaveStart, setleaveStart] = useState('');
  const [leaveEnd, setleaveEnd] = useState('');


function postLeave(body) {
  axios.post('https://localhost:7186/Leave/Leaves/add', {
    firstName: body.firstName,
    lastName: body.lastName,
    reason: body.reason,
    leaveStart: body.leaveStart,
    leaveEnd: body.leaveEnd
  })
  .then(function (response) {
    console.log(response);
  })
  .catch(function (error) {
    console.log(error);
  });

}

const handleSubmit = (e) =>{
    
  const body = {firstName, lastName, typeofLeave, reason, leaveStart, leaveEnd}
  console.log(firstName +" " + lastName +" " + typeofLeave +" " + reason +" " + leaveStart+" " +leaveEnd )
  postLeave(body)
}


const options = [
  { value: 'Sick', label: 'Sick' },
  { value: 'Study', label: 'Study' },
  { value: 'Annual', label: 'Annual' }
]


    return (
      <div className='bg-light justify-content-md-center Container' style={{ display: 'block', 
                  padding: 30, justifyContent:'center' }}>
      <h4>React-Bootstrap Form Component</h4>
      <Form>
      <Form.Group>
          <TextField
              
              id="first-name-input"
              name="first-name"
              label='Enter First Name'
              type="text"
              onChange={(e) => setFirstName(e.target.value)}
              //value={data.firstName}

            />
        </Form.Group>
        <Form.Group>
        <TextField
              
              id="last-name-input"
              name="last-name"
              label='Enter Last Name'
              type="text"
              onChange={(e) => setlastName(e.target.value)}
              //value={data.firstName}

            />
        </Form.Group>
        <Form.Group>
        <TextField
              
              id="reason-input"
              name="reason"
              label='Enter Reason'
              type="text"
              onChange={(e) => setreason(e.target.value)}
              //value={data.firstName}

            />
        </Form.Group>
        <Form.Group>
        <TextField
              
              id="Start Date-input"
              name="Start Date"
              label='Enter Start Date'
              type="text"
              onChange={(e) => setleaveStart(e.target.value)}
              //value={data.firstName}

            />
        </Form.Group>
        <Form.Group>
        <TextField
              
              id="End date-input"
              name="End date"
              label='Enter End date'
              type="text"
              onChange={(e) => setleaveEnd(e.target.value)}
              //value={data.firstName}

            />
        </Form.Group>
        <Form.Group>
        <Form.Label>Leave Type:</Form.Label>

        <Select options={options} onChange={(e) => settypeofLeave(e.target.value)} />
        </Form.Group>
        
        <Button onClick={handleSubmit} style={{margin:10}} variant="primary" type="submit">
           Submit
        </Button>
      </Form>
    </div>
    );
  }