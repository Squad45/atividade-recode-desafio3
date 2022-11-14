import './App.css'
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";

import Home from "./pages/HomePage"
import Projeto from "./pages/ProjectPage"
import Cadastro from "./pages/CadastroPage";
import Contato from "./pages/ContactPage";

import Footer from "./components/Geral/Footer";
import Navbar from "./components/Geral/Navbar";


function App(){
  return (
      <Router>
        <Navbar />
        
        <Routes>

        <Route exact path="/" element={<Home />} />
        <Route exact path="/projeto" element={<Projeto />} />
        <Route exact path="/cadastro" element={<Cadastro />} />
        <Route exact path="/contato" element={<Contato />} />
        
        </Routes>

        <Footer />
      </Router>
  )
}

export default App
