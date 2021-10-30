import { Action as ReduxAction } from "redux";
import { ServiceSwitcherActionType } from "../action-types/ServiceSwitcherActionType";

interface ServiceSwitcherAction extends ReduxAction<ServiceSwitcherActionType> {
    type: ServiceSwitcherActionType
}
export interface ChangeToDotnetAction extends ServiceSwitcherAction {
    type: ServiceSwitcherActionType.DOTNET
}
export interface ChangeToPythonAction extends ServiceSwitcherAction {
    type: ServiceSwitcherActionType.PYTHON
}

export type Action = ChangeToDotnetAction | ChangeToPythonAction