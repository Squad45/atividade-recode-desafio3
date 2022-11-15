import React from "react";
import { Link } from "react-router-dom";
import ImagemFundo from "../assets/Saly-12.png"
import "./CadastroPageCSS.css"
export default function CadastroPage() {
  return (
    <section className="container-fluid sect-form">
      {/* <!-- imagem de fundo --> */}
      <div className="img-back">
          <img src={ImagemFundo} />
      </div>
  
      <main className="main-form-geral">
  
  
      {/* <!-- titulo --> */}
          <h3>Escolha como quer se cadastrar</h3>

          <form className="form-pessoa" id="frmEscolha">
              <div className="div-input">
                               
                <Link to="/cadastro/instituicao" className="ancora-escolha " id="escolha-1">Empresa/Instituição</Link>
                <Link to="/cadastro/pessoa" className="ancora-escolha " id="escolha-2">Pessoa</Link>
                
              </div>
          </form>
      </main>
    </section>
  )
}
