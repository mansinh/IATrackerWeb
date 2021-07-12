import React, { useState } from 'react'
import TopPanel from '../images/characterScreen/top_panel.png'
import BottomPanel from '../images/characterScreen/bottom_panel.png'

import StrainButton from '../components/StrainButton'
import DamageButton from '../components/DamageButton'
import ConditionsButton from '../components/ConditionsButton'

import Interior from '../images/backgrounds/background_interior.jpg'
import Jungle from '../images/backgrounds/background_jungle.jpg'
import Desert from '../images/backgrounds/background_desert.jpg'
import Snow from '../images/backgrounds/background_snow.jpg'
import Bespin from '../images/backgrounds/background_bespin.jpg'
import City from '../images/backgrounds/background_city.jpg'

const CharacterScreen = () => {

    //const [background, setBackground] = useState(Interior);
    const [background, setBackground] = useState(Desert);

    return (
        <div className="app" >
            <img src={background} className="characterScreenImages" style={backgroundStyle} alt="" />
            <img src={TopPanel} className="panel" style={topPanelStyle} alt="" />
            <div style={leftPanelStyle}>
                <DamageButton />
                <StrainButton />
                <ConditionsButton />
            </div>
            <img src={BottomPanel} className="panel" style={bottomPanelStyle} alt="" />
        </div>
    )
}

const topPanelStyle = {
    position: 'absolute',
    top: '0',
}

const leftPanelStyle = {
    position: 'absolute',
    bottom: '15vh',
}


const bottomPanelStyle = {
    position: 'absolute',
    bottom: '0',
}

const backgroundStyle = {
    position: 'absolute',

    background: { Interior },
}



export default CharacterScreen
