import React from "react";
import { Link } from "react-router-dom";


export default function index() {
  return (
    
    // <!-- section da header navbar -->
        <section className="container-fuid">
          <nav 
          className="nav justify-content-center fixed-top nav-bg" id="nav">
              <Link className="nav-link text-light" to={"/"}>HOME</Link>
              <Link className="nav-link text-light" to={"/projeto"}>PROJETOS</Link>
              <Link className="nav-link text-light" to={"/cadastro"}>CADASTRE-SE</Link>
              <Link className="nav-link text-light" to={"/contato"}>CONTATOS</Link>
          </nav>
        </section>
  )
}
