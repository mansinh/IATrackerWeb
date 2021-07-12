import React, { Component, useEffect, useRef } from 'react'
import { useHistory } from 'react-router-dom';
import CharacterSelectButton from '../components/CharacterSelectButton';
import Bio from '../components/BioDialog';
import Biv from '../images/characterSelect/1 Character Select_Biv.png'
import CT1701 from '../images/characterSelect/2 Character Select_CT1701.png'
import Davith from '../images/characterSelect/3 Character Select_Davith.png'
import Diala from '../images/characterSelect/4 Character Select_Diala.png'
import Drokkatta from '../images/characterSelect/5 Character Select_Drokkatta.png'
import Fenn from '../images/characterSelect/6 Character Select_Fenn.png'
import Gaarkhan from '../images/characterSelect/7 Character Select_Gaarkhan.png'
import Gideon from '../images/characterSelect/8 Character Select_Gideon.png'
import Jarrod from '../images/characterSelect/9 Character Select_Jarrod.png'
import Jyn from '../images/characterSelect/10 Character Select_Jyn.png'
import KoTun from '../images/characterSelect/11 Character Select_KoTun.png'
import Loku from '../images/characterSelect/12 Character Select_Loku.png'
import Mak from '../images/characterSelect/13 Character Select_Mak.png'
import Murne from '../images/characterSelect/14 Character Select_Murne.png'
import MHD19 from '../images/characterSelect/15 Character Select_MHD19.png'
import Onar from '../images/characterSelect/16 Character Select_Onar.png'
import Saska from '../images/characterSelect/17 Character Select_Saska.png'
import Shyla from '../images/characterSelect/18 Character Select_Shyla.png'
import Tress from '../images/characterSelect/19 Character Select_Tress.png'
import Vinto from '../images/characterSelect/20 Character Select_Vinto.png'
import Verena from '../images/characterSelect/21 Character Select_Verena.png'


const CharacterSelectScreen = () => {
    const history = useHistory();

    const onSelected = () => {
        history.push('./character')
    }

    const biv = useRef();
    const ct = useRef();
    const davith = useRef();
    const diala = useRef();
    const drokkatta = useRef();
    const fenn = useRef();
    const gaarkhan = useRef();
    const gideon = useRef();
    const jarrod = useRef();
    const jyn = useRef();
    const kotun = useRef();
    const loku = useRef();
    const mak = useRef();
    const murne = useRef();
    const mhd = useRef();
    const onar = useRef();
    const saska = useRef();
    const shyla = useRef();
    const tress = useRef();
    const vinto = useRef();
    const verena = useRef();
    const references = [biv, ct, davith, diala, drokkatta, fenn, gaarkhan, gideon, jarrod, jyn, kotun, loku, mak, murne, mhd, onar, saska, shyla, tress, vinto, verena];

    useEffect(() => {
        for (let index = 0; index < references.length; index++) {
            const element = references[index];

            setTimeout(() => {
                if (element.current != null) {
                    element.current.toggleVisibility();
                }
            }, 100 * index + 200);
        }
    });


    return (
        <div className="app">
            <div style={selectScreenStyle}>

                <br></br>

                <CharacterSelectButton imageSrc={Biv} character={1} onClick={onSelected} ref={biv} />
                <CharacterSelectButton imageSrc={CT1701} character={2} onClick={onSelected} ref={ct} />
                <CharacterSelectButton imageSrc={Davith} character={3} onClick={onSelected} ref={davith} />
                <CharacterSelectButton imageSrc={Diala} character={4} onClick={onSelected} ref={diala} />
                <CharacterSelectButton imageSrc={Drokkatta} character={5} onClick={onSelected} ref={drokkatta} />
                <CharacterSelectButton imageSrc={Fenn} character={6} onClick={onSelected} ref={fenn} />
                <CharacterSelectButton imageSrc={Gaarkhan} character={7} onClick={onSelected} ref={gaarkhan} />
                <CharacterSelectButton imageSrc={Gideon} character={8} onClick={onSelected} ref={gideon} />
                <CharacterSelectButton imageSrc={Jarrod} character={9} onClick={onSelected} ref={jarrod} />
                <CharacterSelectButton imageSrc={Jyn} character={10} onClick={onSelected} ref={jyn} />
                <CharacterSelectButton imageSrc={KoTun} character={11} onClick={onSelected} ref={kotun} />
                <CharacterSelectButton imageSrc={Loku} character={12} onClick={onSelected} ref={loku} />
                <CharacterSelectButton imageSrc={Mak} character={13} onClick={onSelected} ref={mak} />
                <CharacterSelectButton imageSrc={Murne} character={14} onClick={onSelected} ref={murne} />
                <CharacterSelectButton imageSrc={MHD19} character={15} onClick={onSelected} ref={mhd} />
                <CharacterSelectButton imageSrc={Onar} character={16} onClick={onSelected} ref={onar} />
                <CharacterSelectButton imageSrc={Saska} character={17} onClick={onSelected} ref={saska} />
                <CharacterSelectButton imageSrc={Shyla} character={18} onClick={onSelected} ref={shyla} />
                <CharacterSelectButton imageSrc={Tress} character={19} onClick={onSelected} ref={tress} />
                <CharacterSelectButton imageSrc={Vinto} character={20} onClick={onSelected} ref={vinto} />
                <CharacterSelectButton imageSrc={Verena} character={21} onClick={onSelected} ref={verena} />
                <br></br>

            </div>
        </div>
    )
}

const selectScreenStyle = {
    overflowY: 'scroll',
    height: '100vh',
    paddingRight: '30px',
    paddingLeft: '30px',
    display: 'flex',
    flexDirection: 'column',
    backgroundColor: 'rgba(0,0,0,0.8)',
}
const bioDialogStyle = {
    position: 'absolute',
    top: '0',
    left: '500px'
}

export default CharacterSelectScreen
