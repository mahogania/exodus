import { PropertyType } from "../propertyType/PropertyType";
import { Object } from "../object/Object";
import { JsonValue } from "type-fest";

export type Property = {
  createdAt: Date;
  dynamicProperty?: PropertyType | null;
  id: string;
  object?: Object | null;
  updatedAt: Date;
  value: JsonValue;
};
