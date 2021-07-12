import CharacterScreenButton from './CharacterScreenButton'
import DamageIcon from '../images/icons/icon_damage.png'
import { useState } from 'react'

const DamageButton = () => {
    const [damage, setDamage] = useState(0);
    const onDamage = () => {
        setDamage(damage + 1);
    }

    return (
        <>
            <b className={"button-text"} >{damage}</b>
            <CharacterScreenButton imageSrc={DamageIcon} onClick={onDamage} />
        </>
    )
}

export default DamageButton