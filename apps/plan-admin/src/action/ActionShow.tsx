import * as React from "react";

import {
  Show,
  SimpleShowLayout,
  ShowProps,
  DateField,
  TextField,
  ReferenceField,
  ReferenceManyField,
  Datagrid,
} from "react-admin";

import { ACTION_TITLE_FIELD } from "./ActionTitle";
import { STEP_TITLE_FIELD } from "../step/StepTitle";
import { OBJECT_TITLE_FIELD } from "../object/ObjectTitle";

export const ActionShow = (props: ShowProps): React.ReactElement => {
  return (
    <Show {...props}>
      <SimpleShowLayout>
        <DateField source="createdAt" label="Created At" />
        <TextField label="ID" source="id" />
        <ReferenceField label="Object" source="object.id" reference="Object">
          <TextField source={OBJECT_TITLE_FIELD} />
        </ReferenceField>
        <DateField source="updatedAt" label="Updated At" />
        <ReferenceManyField reference="Task" target="actionId" label="Tasks">
          <Datagrid rowClick="show" bulkActionButtons={false}>
            <ReferenceField
              label="Action"
              source="action.id"
              reference="Action"
            >
              <TextField source={ACTION_TITLE_FIELD} />
            </ReferenceField>
            <TextField label="Context" source="context" />
            <DateField source="createdAt" label="Created At" />
            <TextField label="ID" source="id" />
            <TextField label="Kind" source="kind" />
            <ReferenceField label="Step" source="step.id" reference="Step">
              <TextField source={STEP_TITLE_FIELD} />
            </ReferenceField>
            <DateField source="updatedAt" label="Updated At" />
          </Datagrid>
        </ReferenceManyField>
      </SimpleShowLayout>
    </Show>
  );
};
