import { PropertyListRelationFilter } from "../property/PropertyListRelationFilter";
import { ActionListRelationFilter } from "../action/ActionListRelationFilter";
import { AssociationListRelationFilter } from "../association/AssociationListRelationFilter";
import { StringFilter } from "../../util/StringFilter";

export type ObjectWhereInput = {
  Properties?: PropertyListRelationFilter;
  actions?: ActionListRelationFilter;
  associations?: AssociationListRelationFilter;
  id?: StringFilter;
};
