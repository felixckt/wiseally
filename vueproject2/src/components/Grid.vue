<template>
  <div class="row">
        <kendo-button @click="onClick" class="k-primary">Button</kendo-button>
        <kendo-buttongroup :index="3">
            <kendo-buttongroup-button data-icon="play">Option 1</kendo-buttongroup-button>
            <kendo-buttongroup-button data-icon="rewind">Option 2</kendo-buttongroup-button>
            <kendo-buttongroup-button data-icon="play">Option 43</kendo-buttongroup-button>
            <li>Ordinary LI item</li>
        </kendo-buttongroup>
         <kendo-lineargauge :gauge-area-width="300"
                              :scale-major-unit="20"
                              :scale-minor-unit="2"
                              :scale-min="0"
                              :scale-max="180"
                              :scale-vertical="true"
                              :scale-ranges="[{
                                      from: 0,
                                      to: 20,
                                      color: '#2798df'
                                  }, {
                                      from: 50,
                                      to: 80,
                                      color: '#ffc700'
                                  }, {
                                      from: 80,
                                      to: 180,
                                      color: '#c20000'
                                  }]">
                <kendo-lineargauge-pointer :value="bluePointer"
                :color="'blue'"></kendo-lineargauge-pointer>
                <kendo-lineargauge-pointer :value="redPointer"
                :color="'red'"></kendo-lineargauge-pointer>
            </kendo-lineargauge>
            <kendo-arcgauge ref="arcgauge"
                    :scale-min="0"
                    :value="20"
                    :scale-max="100">
        <kendo-arcgauge-color :to="25" :color="'#0058e9'"></kendo-arcgauge-color>
        <kendo-arcgauge-color :from="25" :to="50" :color="'#37b400'"></kendo-arcgauge-color>
        <kendo-arcgauge-color :from="50" :to="75" :color="'#ffc000'"></kendo-arcgauge-color>
        <kendo-arcgauge-color :from="75" :color="'#f31700'"></kendo-arcgauge-color>
    </kendo-arcgauge>
     <kendo-grid :data-source="localDataSource">
        <kendo-grid-column :field="'ProductID'"
                           :title="'ID'"
                           :width="40"></kendo-grid-column>
        <kendo-grid-column :field="'ProductName'"></kendo-grid-column>
        <kendo-grid-column :field="'UnitPrice'"
                           :title="'Unit Price'"
                           :width="120"
                           :format="'{0:c}'"></kendo-grid-column>
        <kendo-grid-column :field="'UnitsInStock'"
                           :title="'Units In Stock'"
                           :width="120"></kendo-grid-column>
        <kendo-grid-column :field="'Discontinued'" :width="120"></kendo-grid-column>
    </kendo-grid>
    </div>
</template>
<script>
export default {
  name: 'HelloWorld',
  props: {
    msg: String,
  },
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
