import React, { useState, forwardRef, useImperativeHandle } from 'react'
import selectSound from "../sounds/select.wav"

const CharacterSelectButton = ({ imageSrc, character, onClick }, ref) => {
    const [pressed, setPressed] = useState(false);

    const [visibility, setVisibility] = useState(false);

    const selectSoundAudio = new Audio(selectSound);

    const handleClick = (index) => {
        //animation
        setPressed(true);

        selectSoundAudio.play();
        setTimeout(() => {
            onClick();
            setPressed(false);

        }, 100);

    }

    useImperativeHandle(ref, () => ({
        toggleVisibility() {
            setVisibility(true);
        }
    }), [])


    return (
        <div className={pressed ? "button-pressed" : null}>
            <img className={visibility ? "button-select" : "button-select-hidden"} src={imageSrc} onClick={handleClick}></img>
        </div>
    )
}

export default forwardRef(CharacterSelectButton)
