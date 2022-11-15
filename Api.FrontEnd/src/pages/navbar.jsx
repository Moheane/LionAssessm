import React from 'react'
import { Link } from "react-router-dom";


export default function Navbar() {
    return (
        <nav className="navbar navbar-expand-sm navbar-light">
  <a className="navbar-brand text-warning">
    LION API
  </a>
  <button
    className="navbar-toggler"
    type="button"
    data-toggle="collapse"
    data-target="#navbarNavDropdown"
    aria-controls="navbarNavDropdown"
    aria-expanded="false"
    aria-label="Toggle navigation"
  >
    <span className="navbar-toggler-icon"></span>
  </button>
  <div className="collapse navbar-collapse" id="navbarNavDropdown">
    <ul className="navbar-nav">
      <li className="nav-item">
        <a className="nav-link" href="#">
          <Link to="/">HOME</Link>
        </a>
      </li>
      <li className="nav-item">
        <a className="nav-link" href="#">
        <Link to="/request">LEAVE REQUEST</Link>
        </a>
      </li>
      

    </ul>
    
  </div>
</nav>
    )
}