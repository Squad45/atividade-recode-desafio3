import './App.css'
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";

import Home from "./pages/HomePage"
import Projeto from "./pages/ProjectPage"
import Navbar from "./components/Navbar";


function App(){
  return (
      <Router>
        <Navbar />
        
        <Routes>

        <Route exact path="/" element={<Home />} />
        <Route exact path="/projeto" element={<Projeto />} />
        </Routes>
      </Router>
  )
}

export default App
