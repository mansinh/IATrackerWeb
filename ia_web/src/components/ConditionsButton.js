import CharacterScreenButton from './CharacterScreenButton'
import ConditionIcon from '../images/icons/icon_condition.png'

const ConditionsButton = () => {

    const onConditions = () => {
    }

    return (
        <>
            <CharacterScreenButton imageSrc={ConditionIcon} onClick={onConditions} />
        </>
    )
}

export default ConditionsButton