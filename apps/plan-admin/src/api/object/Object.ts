import { Property } from "../property/Property";
import { Action } from "../action/Action";
import { Association } from "../association/Association";

export type Object = {
  Properties?: Array<Property>;
  actions?: Array<Action>;
  associations?: Array<Association>;
  createdAt: Date;
  id: string;
  updatedAt: Date;
};
