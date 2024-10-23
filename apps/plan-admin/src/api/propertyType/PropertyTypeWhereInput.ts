import { PropertyListRelationFilter } from "../property/PropertyListRelationFilter";
import { StringFilter } from "../../util/StringFilter";
import { ObjectTypeListRelationFilter } from "../objectType/ObjectTypeListRelationFilter";
import { JsonFilter } from "../../util/JsonFilter";

export type PropertyTypeWhereInput = {
  dynamicPropertyInstances?: PropertyListRelationFilter;
  id?: StringFilter;
  objectTypes?: ObjectTypeListRelationFilter;
  schema?: JsonFilter;
};
