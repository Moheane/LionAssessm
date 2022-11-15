import Table from 'react-bootstrap/Table';
import Container from 'react-bootstrap/Container';
import React, { Fragment, useEffect, useState } from 'react';
import axios from "axios";





export default function Home() {

  const [getAllUsers, setAllUsers] = useState([]);

const getAllTheBrokerF = () => {
    
    axios.get("https://localhost:7186/Leave/Leaves")
    .then((response) => {
        setAllUsers(response.data);
        console.log(response.data)
    })
    .catch((error) => {
    console.log(error);
    });
    };
   // console.log(data)
  useEffect(() => {
    getAllTheBrokerF();
    
  }, [getAllUsers]);
    
    return (
      <Container className='justify-content-md-center Container' style={{ padding: "1rem 0" }}>
        <Table responsive striped bordered hover size="sm">
      <thead>
        <tr>
          <th>First Name</th>
          <th>Last Name</th>
          <th>leave Start</th>
          <th>leave End</th>
          <th>total Leaves Taken</th>
          <th>total Leaves Taken</th>
        </tr>
      </thead>
      <tbody>
      {getAllUsers.map((item, i) => (
            <tr key={i}>
              <td>{item.firstName}</td>
              <td>{item.lastName}</td>
              <td>{item.leaveStart}</td>
              <td>{item.leaveEnd}</td>
              <td>{item.totalLeavesTaken}</td>
              <td>{item.totalLeavesLeft}</td>

            </tr>
          ))}
        
      </tbody>
    </Table>
      </Container>
    );
  }