import React from "react";
import SecaoArtigo from "../components/ProjectPage/Articles";
import SecaoCadastro from "../components/ProjectPage/CadastroSection";
import SecaoFeedback from "../components/ProjectPage/FeedbackSection";

import "./ProjectPageCSS.css";
export default function ProjectPage() {
  return (
    <>
      <section className="container-fluid sect-projeto">
        <main>
          <h1 className="titulo">Conheça o nosso projeto</h1>

          <SecaoArtigo />
        </main>
      </section>

      <SecaoCadastro />

      {/* <!-- section onde terá o feedback, ainda ficticio --> */}
      <SecaoFeedback />
    </>
  );
}
