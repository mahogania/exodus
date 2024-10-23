import { AssociationTypeWhereUniqueInput } from "../associationType/AssociationTypeWhereUniqueInput";
import { StringFilter } from "../../util/StringFilter";
import { ObjectListRelationFilter } from "../object/ObjectListRelationFilter";
import { JsonFilter } from "../../util/JsonFilter";

export type AssociationWhereInput = {
  associationType?: AssociationTypeWhereUniqueInput;
  id?: StringFilter;
  object?: ObjectListRelationFilter;
  value?: JsonFilter;
};
