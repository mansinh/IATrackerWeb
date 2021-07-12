
import React, { useState } from "react";
import selectSound from "../sounds/select.wav"

const ImageButton = ({ imageSrc, onClick }) => {
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
        <div className={pressed ? "button-pressed" : null} >
            <img className={"button-character"} src={imageSrc} onClick={handleClick} />
        </div>
    )
}


export default ImageButton
