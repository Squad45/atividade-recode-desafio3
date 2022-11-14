import React from "react";
import { Link } from "react-router-dom";
import "./style.css";

export default function index() {
  return (
    <section className="container">
      <main className="cadastro-projeto">
        <h2 className="titulo-d">como nosso projeto funciona</h2>
        <div className="row">
          <div className="col-sm col-proj">
            <div className="cad-proj">
              <div>
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  width="60"
                  height="60"
                  fill="currentColor"
                  className="bi bi-bootstrap-reboot"
                  viewBox="0 0 16 16"
                >
                  <path d="M1.161 8a6.84 6.84 0 1 0 6.842-6.84.58.58 0 1 1 0-1.16 8 8 0 1 1-6.556 3.412l-.663-.577a.58.58 0 0 1 .227-.997l2.52-.69a.58.58 0 0 1 .728.633l-.332 2.592a.58.58 0 0 1-.956.364l-.643-.56A6.812 6.812 0 0 0 1.16 8z" />
                  <path d="M6.641 11.671V8.843h1.57l1.498 2.828h1.314L9.377 8.665c.897-.3 1.427-1.106 1.427-2.1 0-1.37-.943-2.246-2.456-2.246H5.5v7.352h1.141zm0-3.75V5.277h1.57c.881 0 1.416.499 1.416 1.32 0 .84-.504 1.324-1.386 1.324h-1.6z" />
                </svg>
              </div>
              <p>
                basta se cadastrar, para ajudar, doando um equipamento, ou caso
                precise de ajuda
              </p>
            </div>
          </div>
          <div className="col-sm col-proj">
            <div className="cad-proj">
              <svg
                xmlns="http://www.w3.org/2000/svg"
                width="60"
                height="60"
                fill="currentColor"
                className="bi bi-box2-heart-fill"
                viewBox="0 0 16 16"
              >
                <path d="M3.75 0a1 1 0 0 0-.8.4L.1 4.2a.5.5 0 0 0-.1.3V15a1 1 0 0 0 1 1h14a1 1 0 0 0 1-1V4.5a.5.5 0 0 0-.1-.3L13.05.4a1 1 0 0 0-.8-.4h-8.5ZM8.5 4h6l.5.667V5H1v-.333L1.5 4h6V1h1v3ZM8 7.993c1.664-1.711 5.825 1.283 0 5.132-5.825-3.85-1.664-6.843 0-5.132Z" />
              </svg>
              <p>
                após se cadastrar, e analisarmos sua situação, entraremos em
                contato o quanto antes
              </p>
            </div>
          </div>
        </div>
        <div className="irCadastro">
          <Link className="cadA-proj" to="/cadastro">
            Cadastre-se Agora!
          </Link>
        </div>
      </main>
    </section>
  );
}
