
import React, { useState } from "react";
import selectSound from "../sounds/select.wav"

const ImageButton = ({ background, onClick }) => {
    const [pressed, setPressed] = useState(false);
    const selectSoundAudio = new Audio(selectSound);

    const handleClick = () => {
        //animation
        setPressed(true);
        selectSoundAudio.play();
        setTimeout(() => {

            setPressed(false);
            onClick();
        }, 100);

    }

    return (
        <div className={pressed ? "button-pressed" : null}>
            <img className={"button-main"} src={background} onClick={handleClick}></img>
        </div>
    )
}


export default ImageButton
