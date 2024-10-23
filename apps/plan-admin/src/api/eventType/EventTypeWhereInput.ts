import { EventListRelationFilter } from "../event/EventListRelationFilter";
import { StringFilter } from "../../util/StringFilter";
import { ObjectTypeListRelationFilter } from "../objectType/ObjectTypeListRelationFilter";
import { JsonFilter } from "../../util/JsonFilter";

export type EventTypeWhereInput = {
  events?: EventListRelationFilter;
  id?: StringFilter;
  objectTypes?: ObjectTypeListRelationFilter;
  schema?: JsonFilter;
};
