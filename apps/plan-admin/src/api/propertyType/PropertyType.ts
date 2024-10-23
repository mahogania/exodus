import { Property } from "../property/Property";
import { ObjectType } from "../objectType/ObjectType";
import { JsonValue } from "type-fest";

export type PropertyType = {
  createdAt: Date;
  dynamicPropertyInstances?: Array<Property>;
  id: string;
  objectTypes?: Array<ObjectType>;
  schema: JsonValue;
  updatedAt: Date;
};
