import React from "react";

import "./style.css";

export default function index() {
  return (
    <section className="container-fluid sect-feedback">
        <main>
          <h2 className="titulo-d">Feedback que participam do projeto </h2>

          <div className="row">
            <div className="col-sm">
              <div className="icon-feedback">
                <svg xmlns="http://www.w3.org/2000/svg" width="40" height="40" fill="currentColor" className="bi bi-person-circle" viewBox="0 0 16 16">
              <path d="M11 6a3 3 0 1 1-6 0 3 3 0 0 1 6 0z"/>
              <path fill-rule="evenodd" d="M0 8a8 8 0 1 1 16 0A8 8 0 0 1 0 8zm8-7a7 7 0 0 0-5.468 11.37C3.242 11.226 4.805 10 8 10s4.757 1.225 5.468 2.37A7 7 0 0 0 8 1z"/>
                </svg> 
                <h5 className="titulo-d">Representante da Escola M</h5>
              </div>
              <p className="parag-feedback">Lorem ipsum dolor sit amet consectetur adipisicing elit. Eligendi nam, maiores dolorum esse laborum, facilis totam, numquam amet aliquid beatae cum! Veritatis, porro? Nisi explicabo, maxime suscipit vero facilis rerum? Nesciunt corrupti sapiente odit voluptatem quo expedita voluptate a labore atque qui cupiditate minus iusto distinctio voluptas aliquam, quasi quaerat.</p>
            </div>
            <div className="col-sm">
              <div className="icon-feedback">
                <svg xmlns="http://www.w3.org/2000/svg" width="40" height="40" fill="currentColor" className="bi bi-person-circle" viewBox="0 0 16 16">
              <path d="M11 6a3 3 0 1 1-6 0 3 3 0 0 1 6 0z"/>
              <path fill-rule="evenodd" d="M0 8a8 8 0 1 1 16 0A8 8 0 0 1 0 8zm8-7a7 7 0 0 0-5.468 11.37C3.242 11.226 4.805 10 8 10s4.757 1.225 5.468 2.37A7 7 0 0 0 8 1z"/>
                </svg> 
                <h5 className="titulo-d">Aluno Roberto Rocha </h5>
              </div>
              <p className="parag-feedback">Lorem ipsum, dolor sit amet consectetur adipisicing elit. Libero quibusdam vero ipsa doloremque illo nisi exercitationem suscipit odio eligendi dolore maiores doloribus, modi ea sapiente provident nulla earum? Voluptate, aliquam?</p>
            </div>
          </div>
        </main>
      </section>
  )
}
