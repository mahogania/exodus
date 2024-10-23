import { AssociationListRelationFilter } from "../association/AssociationListRelationFilter";
import { StringFilter } from "../../util/StringFilter";
import { JsonFilter } from "../../util/JsonFilter";

export type AssociationTypeWhereInput = {
  associations?: AssociationListRelationFilter;
  id?: StringFilter;
  schema?: JsonFilter;
};
