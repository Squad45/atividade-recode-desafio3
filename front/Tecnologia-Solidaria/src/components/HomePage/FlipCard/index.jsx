import React from 'react'
import "./style.css"
export default function index(props) {
  return (
    <div className="col-sm main-col">
        <div className="flip-card">
            <div className="flip-card-inner">
            <div className="flip-card-front">
                    <p className="text">{props.front}</p>
            </div>
                <div className="flip-card-back"> 
                    <p>{props.back}
                    </p> 
                </div>
            </div>
        </div>
    </div>
  )
}
