import React from 'react'
import { Link } from "react-router-dom";
import "./style.css"
import ImagemHeader from "../../../assets/Saly-10.png"
export default function index() {
  return (
    // <!-- section da header -->
    <section>
        <header className="header">
            <div className="conteudo-header">
                <div className="texto-header">
                    <h1>Tecnologia Solidária na Zona Rural</h1>
                    <p>Nos ajude, por meio de doações a dar asas ao sonho de um jovem e inseri-lo ao mundo digital para melhorar seus estudo!</p>

                    <Link className="saiba_mais" to="/projeto">Saiba mais</Link>
                </div>

                <img src={ImagemHeader} alt="Imagem principal de um boneco 3d" className="img-header" />
            </div>
        </header>
    </section>
  )
}
