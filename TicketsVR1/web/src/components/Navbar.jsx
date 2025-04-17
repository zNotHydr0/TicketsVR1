import { NavLink } from 'react-router-dom';
import '../styles/Navbar.css';

const Navbar = () => {
  return (
    <nav className="navbar">
      <ul>
        <li><NavLink to="/">Home</NavLink></li>
        <li><NavLink to="/products">Products</NavLink></li>
        <li><NavLink to="/about">About Us</NavLink></li>
        <li><NavLink to="/contact">Contact</NavLink></li>
      </ul>
    </nav>
  );
};

export default Navbar;