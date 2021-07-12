import CharacterScreenButton from './CharacterScreenButton'
import StrainIcon from '../images/icons/icon_strain.png'
import { useState } from 'react'

const StrainButton = () => {
    const [strain, setStrain] = useState(0);

    const onStrain = () => {
        setStrain(strain + 1)
        console.log(strain + " strain");
    }

    return (
        <>
            <b className={"button-text"} >{strain}</b>
            <CharacterScreenButton imageSrc={StrainIcon} onClick={onStrain} />
        </>
    )
}

export default StrainButton
