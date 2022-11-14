import React from 'react'
import "./style.css"

export default function index(props) {
  return (
    <div class="col-sm div-logo">
        <img class="img-logo" src={props.imagem} alt={`Logo da(o) ${props.titulo}`} />
        <small class="text-muted">{props.titulo}</small>
    </div>
  )
}
