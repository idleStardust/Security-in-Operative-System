import { ServiceSwitcherActionType } from '../action-types/ServiceSwitcherActionType';
import { ChangeToDotnetAction, ChangeToPythonAction } from '../actions/ServiceSwitcherActions';

const actionCreators = {
    requestDotnet: () => ({type: ServiceSwitcherActionType.DOTNET} as ChangeToDotnetAction),
    requestPython: () => ({type: ServiceSwitcherActionType.PYTHON} as ChangeToPythonAction)
}

export default actionCreators;