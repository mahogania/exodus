import * as React from "react";
import {
  Edit,
  SimpleForm,
  EditProps,
  ReferenceInput,
  SelectInput,
} from "react-admin";
import { PropertyTypeTitle } from "../propertyType/PropertyTypeTitle";
import { EventTypeTitle } from "../eventType/EventTypeTitle";

export const ObjectTypeEdit = (props: EditProps): React.ReactElement => {
  return (
    <Edit {...props}>
      <SimpleForm>
        <ReferenceInput
          source="PropertyTypes.id"
          reference="PropertyType"
          label="Property Types"
        >
          <SelectInput optionText={PropertyTypeTitle} />
        </ReferenceInput>
        <ReferenceInput
          source="eventTypes.id"
          reference="EventType"
          label="Event Types"
        >
          <SelectInput optionText={EventTypeTitle} />
        </ReferenceInput>
      </SimpleForm>
    </Edit>
  );
};
