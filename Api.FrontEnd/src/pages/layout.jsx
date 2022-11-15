import React from 'react'
import { Outlet } from "react-router-dom";
import Navbar from './navbar';

export default function Layout() {
    return (
        <main>
        
        <Navbar fixed="top"/>

        <div className='text-center'>
        <Outlet />
        </div>
      </main>
    )
}