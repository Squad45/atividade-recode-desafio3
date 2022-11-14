import React from "react";
import { Link } from "react-router-dom";

export default function index() {
  return (
    // <!-- footer -->
    <section className="container-fuid footer">
      {/* <!-- so pegar algo do bootstrap q ja ta bom --> */}
      <footer className="py-3 my-4">
        <ul className="nav justify-content-center border-bottom pb-3 mb-3">
          <li className="nav-item">
            <Link to="/" className="nav-link px-2 text-muted">
              Home
            </Link>
          </li>
          <li className="nav-item">
            <Link to="/projeto" className="nav-link px-2 text-muted">
              Projeto
            </Link>
          </li>
          <li className="nav-item">
            <Link to="/cadastro" className="nav-link px-2 text-muted">
              Cadastro
            </Link>
          </li>
          <li className="nav-item">
            <Link to="/contato" className="nav-link px-2 text-muted">
              Contatos
            </Link>
          </li>
        </ul>
        <p className="text-center text-muted">
          © 2022 Tecnologia Solidária na Zona Rural
        </p>
      </footer>
    </section>
  );
}
