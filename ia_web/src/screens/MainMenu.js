import React from 'react'
import { useHistory } from 'react-router-dom';
import ImageButton from '../components/ImageButton';
import MainLogo from '../images/mainMenu/main_logo.png'
import NewButton from '../images/mainMenu/new_button.png'
import LoadButton from '../images/mainMenu/load_button.png'
import CreateButton from '../images/mainMenu/create_button.png'
import ImperialButton from '../images/mainMenu/imperial_button.png'


const MainMenu = () => {
    const history = useHistory();

    const onNew = () => {

        history.push('./characterSelect')


    }
    const onLoad = () => {
        history.push('./load')
    }
    const onCreate = () => {
        history.push('./create')
    }
    const onImperial = () => {
        history.push('./imperial')
    }

    return (
        <div className="app">
            <div style={mainMenuStyle}>
                <br></br>
                <img src={MainLogo} style={logoStyle} alt="" />
                <br></br>
                <ImageButton background={NewButton} onClick={onNew} />
                <ImageButton background={LoadButton} onClick={onNew} />
                <ImageButton background={CreateButton} onClick={onNew} />
                <ImageButton background={ImperialButton} onClick={onNew} />

            </div>
        </div>
    )
}

const mainMenuStyle = {
    textAlign: 'center',
    margin: 'auto',
    alignItems: 'center',
    display: 'flex',
    flexDirection: 'column',
    height: '100%',
}

const logoStyle = {
    marginTop: '20px',
    maxWidth: '90%',
    maxHeight: '50vh',
}
export default MainMenu
